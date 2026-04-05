// See https://aka.ms/new-console-template for more information

using TP_MODUL6_103022400008;

SayaMusicTrack m1 = new SayaMusicTrack("Reveries In The Crimson Beyond");
SayaMusicTrack m2 = new SayaMusicTrack("Ripples of Past Reverie");

m1.IncreasePlayCount(10);
m2.IncreasePlayCount(13);

m1.IncreasePlayCount(2);

m1.PrintTrackDetails();
m2.PrintTrackDetails();
