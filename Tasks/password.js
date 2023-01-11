'use strict';
// Generate random password

const GeneratePassword = (alphabet, length) => {
  const MAX = alphabet.length;
  let key = '';
  for (let i = 0; i < length; i++) {
    const Index = Math.floor(Math.random() * MAX);
    key += alphabet[Index];
  }
  return key;
};

require('../Tests/password.js')(GeneratePassword);
