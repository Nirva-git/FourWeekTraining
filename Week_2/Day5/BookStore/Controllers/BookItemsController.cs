﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookItemsController : ControllerBase
    {
        private readonly BooksContext _context;

        public BookItemsController(BooksContext context)
        {
            _context = context;
        }

        // GET: api/BookItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookItem>>> GetBookItems()
        {
          if (_context.BookItems == null)
          {
              return NotFound();
          }
            return await _context.BookItems.ToListAsync();
        }

        // GET: api/BookItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookItem>> GetBookItem(long id)
        {
          if (_context.BookItems == null)
          {
              return NotFound();
          }
            var bookItem = await _context.BookItems.FindAsync(id);

            if (bookItem == null)
            {
                return NotFound();
            }

            return bookItem;
        }

        // PUT: api/BookItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookItem(long id, BookItem bookItem)
        {
            if (id != bookItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(bookItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BookItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookItem>> PostBookItem(BookItem bookItem)
        {
          if (_context.BookItems == null)
          {
              return Problem("Entity set 'BooksContext.BookItems'  is null.");
          }
            _context.BookItems.Add(bookItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBookItem), new { id = bookItem.Id }, bookItem);
        }

        // DELETE: api/BookItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookItem(long id)    
        {
            if (_context.BookItems == null)
            {
                return NotFound();
            }
            var bookItem = await _context.BookItems.FindAsync(id);
            if (bookItem == null)
            {
                return NotFound();
            }

            _context.BookItems.Remove(bookItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookItemExists(long id)
        {
            return (_context.BookItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
