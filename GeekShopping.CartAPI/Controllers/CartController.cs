using GeekShopping.CartAPI.Data.ValueObjects;
using GeekShopping.CartAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.CartAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CartController : ControllerBase
    {
        private ICartRepository _repository;

        public CartController(ICartRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet("find-cart/{id}")]
<<<<<<< HEAD
        public async Task<ActionResult<CartVO>> FindById(string id)
        {
            var cart = await _repository.FindCartByUserId(id);
=======
        public async Task<ActionResult<CartVO>> FindById(string userID)
        {
            var cart = await _repository.FindCartByUserId(userID);
>>>>>>> 3336f885dc99881d5ffbace883ae37379cd4c15e
            if (cart == null) return NotFound();
            return Ok(cart);
        }

<<<<<<< HEAD
        [HttpPost("add-cart")]
=======
        [HttpPost("add-cart/{id}")]
>>>>>>> 3336f885dc99881d5ffbace883ae37379cd4c15e
        public async Task<ActionResult<CartVO>> AddCart(CartVO vo)
        {
            var cart = await _repository.SaveOrUpdateCart(vo);
            if (cart == null) return NotFound();
            return Ok(cart);
        }

<<<<<<< HEAD
        [HttpPut("update-cart")]
=======
        [HttpPut("update-cart/{id}")]
>>>>>>> 3336f885dc99881d5ffbace883ae37379cd4c15e
        public async Task<ActionResult<CartVO>> UpdateCart(CartVO vo)
        {
            var cart = await _repository.SaveOrUpdateCart(vo);
            if (cart == null) return NotFound();
            return Ok(cart);
        }

        [HttpDelete("remove-cart/{id}")]
        public async Task<ActionResult<CartVO>> RemoveCart(int id)
        {
            var status = await _repository.RemoveFromCart(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
