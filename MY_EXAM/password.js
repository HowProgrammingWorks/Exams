// Generate random password
'use strict'
let GeneratePassword = ( alphabet , length ) => {
    const MAX = alphabet.length
     let key = '';
    for ( let i = 0; i < length; i++ ){
      const Index = Math.floor(Math.random() * MAX);
      key = key + alphabet[Index];
    };
    return key
  }
  
  const result = GeneratePassword('abc123', 7);
  console.log(result);