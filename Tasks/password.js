// Generate random password
'use strict';

const generatePassword = (alphabet, length) => {
  let key = '';
  for (let i = 0; i < length; i++) {
    const Index = Math.floor(Math.random() * alphabet.length);
    key = key + alphabet[Index];
  }
  return key;
};

require('../Tests/password.js')(generatePassword);
