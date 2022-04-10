public class BuchungssatzInXml {
    private ulong _KontoNummer;
    private float _Betrag;

    public BuchungssatzInXml(ulong kontonummer, float betrag) {
        _KontoNummer = kontonummer;
        _Betrag = betrag;
    }

    public ulong GetKontoNummer() => _KontoNummer;

    public void SetKonotNummer(uint kontoNummer) => _KontoNummer = kontoNummer;

    public float GetBetrag() => _Betrag;

    public void SetBetrag(float betrag) => _Betrag = betrag;

    public override string ToString() {
        return $"Konotnummer: {_KontoNummer}; Betrag: {_Betrag}";
    }


}