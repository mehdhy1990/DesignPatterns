// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.Mediator;
using DesignPatternPractice.Observer;

OrderService orderService = new ();
TicketStockService ticketStockService = new ();
TTicketResseller ticketRessellerService = new ();

orderService.AddObserver(ticketRessellerService);
orderService.AddObserver(ticketStockService);

orderService.CompleteTask(5,6);