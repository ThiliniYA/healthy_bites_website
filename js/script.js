document.getElementById('registrationForm').addEventListener('submit', function(event) {
    event.preventDefault();
    
   // Get form values
    const firstName = document.getElementById('firstName').value;
    const lastName = document.getElementById('lastName').value;
    const email = document.getElementById('email').value;
    const mobile = document.getElementById('mobile').value;
    const password = document.getElementById('password').value;
    const confirmPassword = document.getElementById('confirmPassword').value;
    
    const messageElement = document.getElementById('message');
    
  // Check if passwords match
    if (password !== confirmPassword) {
        messageElement.textContent = 'Error: Passwords do not match!';
        messageElement.className = 'error';
        return;
    }
    
  // Success message
    messageElement.textContent = `Registration successful! Welcome, ${firstName} ${lastName}. Email: ${email}, Mobile: ${mobile}`;
    messageElement.className = 'success';
    
   
});