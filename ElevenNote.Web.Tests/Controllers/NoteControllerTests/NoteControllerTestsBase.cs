using ElevenNote.Services;
using ElevenNote.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ElevenNote.Web.Tests.Controllers.NoteControllerTests
{
    [TestClass]
    public abstract class NoteControllerTestsBase
    {
        protected NoteController Controller;
        protected FakeNoteService NoteService;

        [TestInitialize]
        public virtual void Arrange()
        {
            NoteService = new FakeNoteService();

            Controller = new NoteController(
                new Lazy<INoteService>(() => NoteService));
        }
    }
}