
namespace SmallKatas
{
    public class OneHundredDoors
    {
        int startDoor = 1;

        public bool[] PassByDoors(bool[] initialDoors)
        {
            for (int index = startDoor-1; index < initialDoors.Length; index+=startDoor)
            {
                initialDoors[index] = !initialDoors[index];
            }
            startDoor += 1;

            return initialDoors;
        }
    }
}
