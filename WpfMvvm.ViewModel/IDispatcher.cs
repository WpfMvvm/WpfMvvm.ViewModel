using System.Windows.Threading;

namespace WpfMvvm.ViewModel
{
    /// <summary>Интерфейс предоставляющий свойство с диспетчером.</summary>
    public interface IDispatcher
    {
        /// <summary>Диспетчер экземпляра.<br/>
        /// Если <see langword="null"/> значит для экземпляра 
        /// не важно в каком потоке он работает.</summary>
      Dispatcher Dispatcher { get; }
    }
}
