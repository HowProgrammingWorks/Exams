// Generate random password
'use strict';
const generatePassword = (symbols, passwordLength) => {
  const max = symbols.length;
  let password = '';
  for (let i = 0; i < passwordLength; i++) {
    const element = Math.floor(Math.random() * max);
    password += symbols[element];
  }
  return password;
};
const result = generatePassword('abc123', 7);
console.log(result);
