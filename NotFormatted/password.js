// Generate random password

let GeneratePassword = ( alphabet , length ) => {
  const MAX = alphabet.length
  key = '';
  for ( let i = 0; i < length; i++ ){
    Index = Math.floor(Math.random() * MAX);
    key = key + alphabet[Index];
  };
  return key
}

require('../Tests/password.js')(GeneratePassword);
