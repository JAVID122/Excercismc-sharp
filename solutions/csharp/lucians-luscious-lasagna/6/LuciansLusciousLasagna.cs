class Lasagna
{
    private int ExpectedMinutes = 40;


    public int ExpectedMinutesInOven() => ExpectedMinutes;


    public int RemainingMinutesInOven(int actualMinutes) => ExpectedMinutesInOven() - actualMinutes;

    
    public int PreparationTimeInMinutes(int layers) =>  layers * 2;



    public int ElapsedTimeInMinutes(int layers, int minutesInOven) =>     PreparationTimeInMinutes(layers) + minutesInOven;

}
