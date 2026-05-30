class Lasagna
{
    // A constant or field used inside the class
    private int ExpectedMinutes = 40;

    // 1. Returns expected oven time (40 mins)
    public int ExpectedMinutesInOven()=> ExpectedMinutes;


    // 2. Calculates remaining minutes based on actual time spent in oven
    public int RemainingMinutesInOven(int actualMinutes)
    {
        return ExpectedMinutesInOven() - actualMinutes;
    }

    // 3. Calculates preparation time (2 minutes per layer)
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // 4. Calculates total elapsed time (prep time + time spent in oven)
    public int ElapsedTimeInMinutes(int layers, int minutesInOven)
    {
        return PreparationTimeInMinutes(layers) + minutesInOven;
    }
}
