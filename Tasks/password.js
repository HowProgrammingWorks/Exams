// Generate random password

const GeneratePassword = (alphabet, length) => {
  key = '';
  for (let i = 0, MAX = alphabet.length; i < length; i++) {
    Index = Math.floor(Math.random() * MAX);
    key = key + alphabet[Index];
  }
  return key;
};

require('../Tests/password.js')(GeneratePassword);
