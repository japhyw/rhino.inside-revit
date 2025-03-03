using System;

namespace RhinoInside.Revit.External.DB
{
  public static class UniqueId
  {
    public static string Format(Guid episodeId, int index) => $"{episodeId:D}-{index,8:x}";
    public static bool TryParse(string s, out Guid episodeId, out int id)
    {
      episodeId = Guid.Empty;
      id = -1;
      if (s.Length != 36 + 1 + 8)
        return false;

      return Guid.TryParseExact(s.Substring(0, 36), "D", out episodeId) &&
             s[36] == '-' &&
             int.TryParse(s.Substring(36 + 1, 8), System.Globalization.NumberStyles.AllowHexSpecifier, null, out id);
    }

  }

  public static class FullUniqueId
  {
    public static string Format(Guid documentId, string uniqueId) => $"{documentId:D}-{uniqueId}";
    public static bool TryParse(string s, out Guid documentId, out string uniqueId)
    {
      documentId = Guid.Empty;
      uniqueId = String.Empty;
      if (s.Length < 36 + 36 + 1 + 8)
        return false;

      if (Guid.TryParseExact(s.Substring(0, 36), "D", out documentId) && s[36] == '-')
      {
        uniqueId = s.Substring(36 + 1);
        return true;
      }

      return false;
    }
  }
}
