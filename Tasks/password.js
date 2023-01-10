// Generate random password
'use strict';

const generatePassword = (alphabet, length) => {
  const MAX = alphabet.length;
  let key = '';
  for (let i = 0; i < length; i++) {
    let index = Math.floor(Math.random() * MAX);
    key += alphabet[index];
  }
  return key;
};

require('../Tests/password.js')(generatePassword);
