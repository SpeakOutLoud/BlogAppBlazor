﻿namespace BlogApp.Domain.Dtos
{
    public class CommentDto : CommentDtoCreate
    {
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsEdited { get; set; }
    }

    public class CommentDtoCreate
    {
        public string Content { get; set; }
    }
}