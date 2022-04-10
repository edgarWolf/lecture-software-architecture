public class DispositionsAdapter : IDisposition {
    private DispositionsProgramm _DispositionsProgramm;

    public DispositionsAdapter(DispositionsProgramm dispositionsProgramm) {
        _DispositionsProgramm = dispositionsProgramm;
    }

    public bool Dispoiniere(BuchungssatzInXml b) {
        ulong kontoNummer = b.GetKontoNummer();
        float betrag = b.GetBetrag();

        return _DispositionsProgramm.Dispoiniere(kontoNummer, betrag) == 1;
    }
}