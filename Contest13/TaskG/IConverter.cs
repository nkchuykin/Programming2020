public interface IConverter<in TU, out TV>
{
    TV Convert(TU obj);
}