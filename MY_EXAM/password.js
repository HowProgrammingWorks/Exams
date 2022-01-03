// Generate random password
'use strict'
let generatePassword = ( symbols , passwordLength ) => {
    const MAX = symbols.length
     let password = '';
    for ( let i = 0; i < passwordLength; i++ ){
      const element = Math.floor(Math.random() * MAX);
      password = password + symbols[element];
    };
    return password
  }
  
  const result = generatePassword('abc123', 7);
  console.log(result);