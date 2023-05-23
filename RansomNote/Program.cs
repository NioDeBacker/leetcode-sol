using System;

bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length > magazine.Length) {
            return false;
        }
        foreach (char c in ransomNote) {
            int positionInMagazine = magazine.IndexOf(c);
            Console.WriteLine(c);
            Console.WriteLine(positionInMagazine);
            if (positionInMagazine < 0) {
                return false;
            } else {
                magazine = magazine.Remove(positionInMagazine, 1);
                Console.WriteLine(magazine);
            }
        }
        return true;
    }
bool result = CanConstruct("aa", "aab");
bool result2 = CanConstruct("aa", "ab");