// Generate random password

const generatePassword = ( symbolPassword , lengthPassword ) => {
  const max = symbolPassword.length
  let password = '';
  for ( let i = 0; i < lengthPassword; i++ ){
    const index = Math.floor(Math.random() * max);
    password = password + symbolPassword[index];
  };
  return password
}

const result = generatePassword('abc123', 7);
console.log(result);
