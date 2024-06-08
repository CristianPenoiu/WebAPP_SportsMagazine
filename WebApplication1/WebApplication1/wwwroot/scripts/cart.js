// cart.js

function readLocalStorage() {
    if (typeof(Storage) !== "undefined") {
      if (localStorage.getItem("cartItems")) {
        var storedData = JSON.parse(localStorage.getItem("cartItems"));
        var output = "";
        storedData.forEach(function(item) {
          output += "<div class='product'>" + item + "</div>";
        });
        document.getElementById("cart-list").innerHTML = output;
      } else {
        document.getElementById("cart-list").innerHTML = "<strong>No items found in cart</strong>";
      }
    } else {
      document.getElementById("cart-list").innerHTML = "<strong>Sorry, your browser does not support Web Storage (localStorage).</strong>";
    }
  }

// Call the function when the page loads
window.onload = readLocalStorage;
