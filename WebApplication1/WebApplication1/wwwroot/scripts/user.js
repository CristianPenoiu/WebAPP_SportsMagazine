document.getElementById('submitForm').addEventListener('click', function () {
    var fullName = document.getElementById('fullName').value;
    var email = document.getElementById('eMail').value;
    var phone = document.getElementById('phone').value;
    var website = document.getElementById('website').value;
    var street = document.getElementById('Street').value;
    var city = document.getElementById('ciTy').value;
    var state = document.getElementById('sTate').value;
    var zipCode = document.getElementById('zIp').value;

    var data = {
        fullName: fullName,
        email: email,
        phone: phone,
        website: website,
        street: street,
        city: city,
        state: state,
        zipCode: zipCode
    };

    fetch('/Users/Create', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    }).then(response => {
        if (response.ok) {
            console.log('Datele au fost trimise cu succes!');
            // Poți face aici orice acțiune adițională după trimiterea cu succes a datelor
        } else {
            console.error('Eroare la trimiterea datelor!');
        }
    }).catch(error => {
        console.error('Eroare la trimiterea datelor:', error);
    });
});