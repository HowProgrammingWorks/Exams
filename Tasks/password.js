// Generate random password
'use strict';

const generatePassword = (alphabet, length) => {
  let key = '';
  for (let i = 0; i < length; i++) {
    const index = Math.floor(Math.random() * alphabet.length);
    key += alphabet[index];
  }
  return key;
};

require('../Tests/password.js')(generatePassword);
