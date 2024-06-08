// Funcție pentru adăugarea produsului în coșul de cumpărături
function addToCart() {
    // Aici poți implementa logica pentru adăugarea produsului în coș
    console.log('Product added to cart');
}

// Selectăm toate butoanele cu clasa "add-to-cart-btn"
var addToCartButtons = document.querySelectorAll('.add-to-cart-btn');

// Iterăm prin fiecare buton și adăugăm un eveniment de clic
addToCartButtons.forEach(function(button) {
    button.addEventListener('click', function() {
        addToCart(); // Apelăm funcția pentru adăugarea produsului în coș
    });
});