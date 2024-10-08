namespace Modul5;

public class TestDiceCup
{
    public static void Run()
    {
        DiceCup dc = new DiceCup(5);

        List<CupLiftEvent> events = dc.GetHistory();

        for (int i = 0; i < 3; i++)
        {
            Console.ReadLine();
            dc.ShakeCup();
            dc.LiftCup();

            Console.WriteLine(string.Join(", ", dc.eyesList));
        }

        Console.ReadLine();

        events = dc.GetHistory();
        for (int i = 0; i < events.Count; i++)
        {
            string eyesString = string.Join(", ", events[i]._eventEyes);
            Console.WriteLine($"Cup Lift {i} -- Date: {events[i]._eventTime}. Eyes: {eyesString}");
        }


    }
}