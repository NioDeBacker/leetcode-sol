public class ParkingSystem {
    private int[] space;

    public ParkingSystem(int big, int medium, int small) {
        this.space = new int[]{big, medium, small};
    }
    
    public bool AddCar(int carType) {
        if (this.space[carType - 1] > 0) {
            this.space[carType -1] -= 1;
            return true;
        }

        return false;
    }
}
