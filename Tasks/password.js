'use strict';

const GeneratePassword = (alphabet, length) => {
  const max = alphabet.length;
  let key = '';
  for (let i = 0; i < length; i++) {
    Index = Math.floor(Math.random() * max);
    key = key + alphabet[Index];
  }
  return key;
};

require('../Tests/password.js')(GeneratePassword);
