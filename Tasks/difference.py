def difference(FirtsObject, SecondObject):
    if FirtsObject == SecondObject:
        return False
    for element in SecondObject:
        FirtsObject[element] = SecondObject[element]
        del FirtsObject[element]
    return FirtsObject
result = difference({ 'a': 'uno', 'b': 'due' }, { 'a': 'uno', 'c': 'tre' })
print(result)