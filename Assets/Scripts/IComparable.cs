public interface IComparable {
    public bool Menor(IComparable otro);
    public bool Igual(IComparable otro);
    public bool Mayor(IComparable otro);
    public bool MayorOIgual(IComparable otro);
    public bool MenorOIgual(IComparable otro);
}
