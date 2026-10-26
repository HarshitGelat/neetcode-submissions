public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int i = 0;
        int j = people.Length - 1;
        int boats = 0;

        while (i <= j) {
            // If the lightest and heaviest can share a boat, both get on
            if (people[i] + people[j] <= limit) {
                i++;
            }
            // The heaviest person always gets on a boat (either alone or paired)
            j--;
            
            // One boat is used regardless of whether it took 1 or 2 people
            boats++;
        }

        return boats;
    }
}