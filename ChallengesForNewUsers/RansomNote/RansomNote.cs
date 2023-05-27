public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length > magazine.Length) {
            return false;
        }
        foreach (char c in ransomNote) {
            int positionInMagazine = magazine.IndexOf(c);
            if (positionInMagazine < 0) {
                return false;
            } else {
                magazine = magazine.Remove(positionInMagazine, 1);
            }
        }
        return true;
    }
}
