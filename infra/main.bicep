// add target scope to subscription
targetScope = 'subscription'
// add parameters for name and location that defaults to koreacentral
param name string = 'myResourceGroupName'
param location string = 'koreacentral'
// add name with the prefix of 'rg-'
var rgName = 'rg-${name}'
// add resource group
resource rg 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: rgName
  location: location
}


// Create a resource group
resource myResourceGroup 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: name
  location: location
}

// Call a module and set its scope to the resource group
module appsvc './resources.bicep' = {
  name: 'AppService'
  scope: rg
  params: {
    name: name
    location: location
  }
}
