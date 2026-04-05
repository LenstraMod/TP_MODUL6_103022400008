// See https://aka.ms/new-console-template for more information

using TP_MODUL6_103022400008;

SayaMusicTrack m1 = new SayaMusicTrack("Reveries In The Crimson Beyond");
SayaMusicTrack m2 = new SayaMusicTrack("Ripples of Past Reverie");

m1.IncreasePlayCount(10);
m2.IncreasePlayCount(13);

m1.IncreasePlayCount(2);

m1.PrintTrackDetails();
m2.PrintTrackDetails();

//Debug Assertion
//SayaMusicTrack m3 = new SayaMusicTrack("test");

//m3.IncreasePlayCount(100000000);


//Try Catch
//for (int i = 0; i < 215; i++)
//{
//    m1.IncreasePlayCount(10000000);
//}

//m1.PrintTrackDetails();

