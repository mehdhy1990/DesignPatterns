// See https://aka.ms/new-console-template for more information

using DesignPatternPractice.Mediator;

var chatroom = new ChatRoom();
var mehdi = new Lawyer("mehdi");
var massod = new Lawyer("massod");
var merss = new Lawyer("merss");

mehdi.SetChatRoom(chatroom);
massod.SetChatRoom(chatroom);
merss.SetChatRoom(chatroom);

chatroom.Register(mehdi);
chatroom.Register(massod);
chatroom.Register(merss);

merss.SendMessage("hello to all of you!");