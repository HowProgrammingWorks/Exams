// Generate random password

const GeneratePassword = (alphabet, length) => {
  key = '';
  for (let i = 0, MAX = alphabet.length; i < length; i++) {
    key += alphabet.charAt(Math.floor(Math.random() * MAX));
  }
  return key;
};

require('../Tests/password.js')(GeneratePassword);
