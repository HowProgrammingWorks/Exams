// Generate random password
'use strict';

const generateKey = (alphabet, length) => {
  const max = alphabet.length;
  key = '';
  for (let i = 0; i < length; i++) {
    Index = Math.floor(Math.random() * max);
    key = key + alphabet[Index];
  }
  return key;
};

require('../Tests/password.js')(generateKey);
