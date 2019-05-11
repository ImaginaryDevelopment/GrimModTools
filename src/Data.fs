module Data
type Tag =
    |TagConversion
    // requires shield, 2h, ranged, dual,etc...
    |TagHandRestriction of req:string

type Theme =
    |GD
    |D3
    |Titan
    |Other

type Skill = {
  name: string
  tags: Tag list
}

type GdClass = {
  name:string
  theme:Theme
  skills: Skill list
}

let gdClasses : GdClass list = [
  {
    name:"Rogue",
    theme:"Titan",
    skills: [
      {
            name: "Calculated Strike",
            tags: [
            ]
      }
    ]
  }
]
