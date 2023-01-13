// Generate random password
'use strict'

const GeneratePassword = (alphabet, passLength) => {
  let password = '';
  for (let i = 0; i < passLength; i++) password += alphabet[Math.floor(Math.random() * alphabet.length)];
  return password;
};

require('../Tests/password.js')(GeneratePassword);
