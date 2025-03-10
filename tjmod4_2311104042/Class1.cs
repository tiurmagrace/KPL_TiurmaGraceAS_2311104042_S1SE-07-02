using System;

class PosisiKarakterGame
{
    private string state;

    public PosisiKarakterGame()
    {
        state = "Berdiri"; // State awal
    }

    public void UbahState(string stateBaru)
    {
        if (stateBaru == "Berdiri")
        {
            Console.WriteLine("posisi standby");
        }
        else if (stateBaru == "Tengkurap")
        {
            Console.WriteLine("posisi istirahat");
        }

        state = stateBaru; // Perbarui state karakter
    }
}

class Class1
{
    static void Main()
    {
        PosisiKarakterGame karakter = new PosisiKarakterGame();

        // Simulasi perubahan state sesuai aturan NIM % 3 == 1
        karakter.UbahState("Berdiri");   // Output: posisi standby
        karakter.UbahState("Tengkurap"); // Output: posisi istirahat
    }
}