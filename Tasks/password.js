'use strict';
// Generate random password

const generatePassword = (alphabet, length = 8) => {
  if (!Array.isArray(alphabet) && typeof alphabet !== 'string') {
    throw new Error('Argument [alphabet] is not an Array or String');
  }

  if (typeof length !== 'number') {
    throw new Error('Argument [length] is not a Number');
  }

  let password = '';

  for (let i = 0; i < length; i++) {
    const index = Math.floor(Math.random() * alphabet.length);
    password += alphabet[index];
  }

  return password;
};

require('../Tests/password.js')(generatePassword);
