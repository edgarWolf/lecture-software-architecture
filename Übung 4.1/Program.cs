BuchungssatzInXml b1 = new BuchungssatzInXml(1, 30.0f);
BuchungssatzInXml b2 = new BuchungssatzInXml(2, 51.0f);

IDisposition dispositionsAdapter = new DispositionsAdapter(new DispositionsProgramm());

Console.WriteLine($"Status der Buchung des Buchungssatzes {b1} : { (dispositionsAdapter.Dispoiniere(b1) ? "Erfolgreich" : "Fehlgeschlagen") }");
Console.WriteLine($"Status der Buchung des Buchungssatzes {b2} : { (dispositionsAdapter.Dispoiniere(b2) ? "Erfolgreich" : "Fehlgeschlagen") }");