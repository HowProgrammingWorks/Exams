'use strict';
// Generate random password

const generatePassword = (alphabet, length) => {
  const max = alphabet.length;
  let password = '';
  for (let i = 0; i < length; i++) {
    const index = Math.floor(Math.random() * max);
    password += alphabet[index];
  }
  return password;
};

require('../Tests/password.js')(generatePassword);
