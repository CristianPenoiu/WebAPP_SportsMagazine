var cartProducts = [];

// Funcție pentru adăugarea unui produs în coșul de cumpărături
function addToCart(productId) {
    // Aici poți implementa logica pentru adăugarea produsului în coș
    // De exemplu, poți stoca temporar produsul într-un obiect sau array
    // În exemplul de mai jos, adăugăm produsul în array-ul cartProducts
    cartProducts.push(productId);
    console.log('Product added to cart:', productId);
}

// Butonul "Adaugă în coș" pentru fiecare produs
var addToCartButtons = document.querySelectorAll('.add-to-cart-btn');
addToCartButtons.forEach(function(button) {
    button.addEventListener('click', function() {
        var productId = this.getAttribute('data-id');
        addToCart(productId);
    });
});