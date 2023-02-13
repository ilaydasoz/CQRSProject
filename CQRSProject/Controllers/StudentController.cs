using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSProject.CQRS.Handlers.ProductHandlers;
using CQRSProject.CQRS.Commands.StudentCommands;
using CQRSProject.CQRS.Handlers.StudentHandlers;
using CQRSProject.CQRS.Queries.StudentQueries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        private readonly GetAllStudentQueryHandler _getAllStudentQueryHandler;
        private readonly RemoveStudentCommandHandler _removeStudentHandler;
        private readonly GetStudentByIDQueryHandler _getStudentByIDQueryHandler;
        private readonly UpdateStudentCommandHandler _updateStudentCommandHandler;

        public StudentController(CreateStudentCommandHandler createStudentCommandHandler, GetAllStudentQueryHandler getAllStudentQueryHandler, RemoveStudentCommandHandler removeStudentHandler, GetStudentByIDQueryHandler getStudentByIDQueryHandler, UpdateStudentCommandHandler updateStudentCommandHandler)
        {
            _createStudentCommandHandler = createStudentCommandHandler;
            _getAllStudentQueryHandler = getAllStudentQueryHandler;
            _removeStudentHandler = removeStudentHandler;
            _getStudentByIDQueryHandler = getStudentByIDQueryHandler;
            _updateStudentCommandHandler = updateStudentCommandHandler;
        }
        public IActionResult GetAllStudents()
        {
            var values = _getAllStudentQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(CreateStudentCommand createStudentCommand)
        {
            _createStudentCommandHandler.Handle(createStudentCommand);
            return RedirectToAction("GetAllStudents");
        }

        public IActionResult DeleteStudent(int id)
        {
            _removeStudentHandler.Handle(new RemoveStudentCommand(id));
            return RedirectToAction("GetAllStudents");
        }
        
        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            var values = _getStudentByIDQueryHandler.Handle(new GetStudentByIDQuery(id));
            return View(values);

        }

        private static GetStudentByIDQuery GetStudentByIDQuery(int id)
        {
            return new GetStudentByIDQuery(id);
        }

        [HttpPost]
        public IActionResult UpdateStudent(UpdateStudentCommand command)
        {
            _updateStudentCommandHandler.Handle(command);
            return RedirectToAction("GetAllStudents");

        }
    }
}
