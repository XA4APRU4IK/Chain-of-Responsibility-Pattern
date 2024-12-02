using Chain_of_Responsibility_Pattern;
class Program
{
    static void Main(string[] args)
    {
        //обработчики
        var handlerA = new ConcreteHandlerA();
        var handlerB = new ConcreteHandlerB();
        var handlerC = new ConcreteHandlerC();

        handlerA.SetNext(handlerB);
        handlerB.SetNext(handlerC);

        //запросы
        var requestA = new EventRequest("TypeA", "Событие A");
        var requestB = new EventRequest("TypeB", "Событие B");
        var requestC = new EventRequest("TypeC", "Событие C");
        var requestD = new EventRequest("TypeD", "Событие D"); // Необработанное событие

        // Отправляем запросы по цепочке
        handlerA.HandleRequest(requestA);
        handlerA.HandleRequest(requestB);
        handlerA.HandleRequest(requestC);
        handlerA.HandleRequest(requestD); // Этот запрос не будет обработан
    }
}
