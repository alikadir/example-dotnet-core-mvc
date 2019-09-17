workflow "Asp.Net Core Build & Deploy" {
  on = "push"
  resolves = ["Heroku Push"]
}

action "Setup Dotnet for use with actions" {
  uses = "actions/setup-dotnet@6c0e2a2a6b8dbd557c411f0bd105b341d4ce40d2"
  runs = "dotnet build"
  args = "--configuration Release"
}

action "GitHub Action for Heroku" {
  uses = "actions/heroku@466fea5e8253586a6df75b10e95447b0bfe383c1"
  needs = ["Setup Dotnet for use with actions"]
  secrets = ["ASPNETCORE_DB_PATH", "HEROKU_API_KEY"]
  runs = "heroku git:remote"
  args = "-a akb-first-dotnet-core-mvc"
}

action "Heroku Push" {
  uses = "akb"
  needs = ["GitHub Action for Heroku"]
  runs = "git push heroku master"
  secrets = ["HEROKU_API_KEY"]
}
