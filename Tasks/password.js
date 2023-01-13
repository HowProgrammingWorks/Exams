'use strict';

// Generate random password.

const generatePassword = (symbols, passwordLength) => {
  const symbolsRange = symbols.length;
  let password = '';
  for (let i = 0; i < passwordLength; i++) {
    const index = Math.floor(Math.random() * symbolsRange);
    password += symbols[index];
  }
  return password;
};

require('../Tests/password.js')(generatePassword);

