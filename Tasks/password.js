'use strict';
// Generate random password

const generatePassword = (alphabet, length) => {
  const MAX = alphabet.length;
  let password = '';

  for (let i = 0; i < length; i++) {
    const index = Math.floor(Math.random() * MAX);
    password += alphabet[index];
  }

  return password;
};

require('../Tests/password.js')(generatePassword);
