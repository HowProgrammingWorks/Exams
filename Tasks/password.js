'use strict';

// Generate random password

const generatePassword = (symbols, length) => {
  const MAX = symbols.length;
  let key = '';
  for (let i = 0; i < length; i++) {
    const index = Math.floor(Math.random() * MAX);
    key += symbols[index];
  };
  return key;
};

require('../Tests/password.js')(generatePassword);
