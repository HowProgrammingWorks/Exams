// Generate random password
'use strict'

const GeneratePassword = (alphabet, passLength) => {
  const MAX = alphabet.length;
  let password = '';
  for (let i = 0; i < passLength; i++) {
    let Index = Math.floor(Math.random() * MAX);
    password = password + alphabet[Index];
  }
  return key;
};

require('../Tests/password.js')(GeneratePassword);
