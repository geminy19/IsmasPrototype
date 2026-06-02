using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IsmasPrototype.Data;
using IsmasPrototype.Models;

namespace IsmasPrototype.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var students = from s in _context.Students
                           select s;

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                students = students.Where(s =>
                    s.FirstNameBg.Contains(searchString) ||
                    s.MiddleNameBg.Contains(searchString) ||
                    s.LastNameBg.Contains(searchString) ||
                    s.FirstNameEn.Contains(searchString) ||
                    s.MiddleNameEn.Contains(searchString) ||
                    s.LastNameEn.Contains(searchString) ||
                    s.Email.Contains(searchString) ||
                    s.PhoneNumber.Contains(searchString) ||
                    s.NationalIdNumber.Contains(searchString));
            }

            return View(await students.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstNameBg,MiddleNameBg,LastNameBg,FirstNameEn,MiddleNameEn,LastNameEn,CitizenshipCountry,IdCardNumber,IdCardIssueDate,IdCardIssuedBy,PassportNumber,PassportIssueDate,DateOfBirth,NationalIdNumber,Age,Gender,MaritalStatus,BirthCity,BirthCountry,Nationality,PhoneCountryCode,PhoneNumber,Email,PermanentCountry,PermanentCity,PermanentVillage,PermanentPostalCode,PermanentDistrict,PermanentStreet,PermanentStreetNumber,PermanentBlock,PermanentEntrance,PermanentFloor,PermanentApartment,CurrentCountry,CurrentCity,CurrentVillage,CurrentPostalCode,CurrentDistrict,CurrentStreet,CurrentStreetNumber,CurrentBlock,CurrentEntrance,CurrentFloor,CurrentApartment,EmergencyFirstName,EmergencyLastName,EmergencyPhoneCountryCode,EmergencyPhoneNumber,UniversityCountry,UniversityCity,UniversityName,Major,UniversityStartDate,UniversityEndDate,DegreeType,HasPreviousEducation,PreviousUniversityName,PreviousMajor,PreviousEducationPeriod,PreviousDegreeType,HasAppliedForVisaBefore,PreviousJ1VisaCount,PreviousVisaNotes,Season,Office,Status")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstNameBg,MiddleNameBg,LastNameBg,FirstNameEn,MiddleNameEn,LastNameEn,CitizenshipCountry,IdCardNumber,IdCardIssueDate,IdCardIssuedBy,PassportNumber,PassportIssueDate,DateOfBirth,NationalIdNumber,Age,Gender,MaritalStatus,BirthCity,BirthCountry,Nationality,PhoneCountryCode,PhoneNumber,Email,PermanentCountry,PermanentCity,PermanentVillage,PermanentPostalCode,PermanentDistrict,PermanentStreet,PermanentStreetNumber,PermanentBlock,PermanentEntrance,PermanentFloor,PermanentApartment,CurrentCountry,CurrentCity,CurrentVillage,CurrentPostalCode,CurrentDistrict,CurrentStreet,CurrentStreetNumber,CurrentBlock,CurrentEntrance,CurrentFloor,CurrentApartment,EmergencyFirstName,EmergencyLastName,EmergencyPhoneCountryCode,EmergencyPhoneNumber,UniversityCountry,UniversityCity,UniversityName,Major,UniversityStartDate,UniversityEndDate,DegreeType,HasPreviousEducation,PreviousUniversityName,PreviousMajor,PreviousEducationPeriod,PreviousDegreeType,HasAppliedForVisaBefore,PreviousJ1VisaCount,PreviousVisaNotes,Season,Office,Status")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
