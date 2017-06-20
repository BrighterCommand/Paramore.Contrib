﻿using Newtonsoft.Json;
using Paramore.Brighter;
using Tasks.Ports.Events;

namespace TasksCoreApi.MessageMappers
{
    public class TaskEditedEventMapper : IAmAMessageMapper<TaskEditedEvent>

    {
        public Message MapToMessage(TaskEditedEvent request)
        {
            var header = new MessageHeader(messageId: request.Id, topic: "Task.Edited", messageType: MessageType.MT_EVENT);
            var body = new MessageBody(JsonConvert.SerializeObject(request));
            var message = new Message(header, body);
            return message;
        }

        public TaskEditedEvent MapToRequest(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}