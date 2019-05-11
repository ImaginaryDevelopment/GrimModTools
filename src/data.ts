interface Tag {
  name: string
  kind: string
}
interface TagConversion extends Tag {
  kind:"TagConversion"
}
// requires shield, 2h, ranged, dual,etc...
interface TagHandRestriction extends Tag {
  kind:"TagHandRestriction"
    requirement:string
}

type SkillTag = TagHandRestriction|TagConversion|Tag;

interface Skill {
    name: string
  tags: SkillTag []
}

interface GdClass {
  name:string;
  theme:"GD"|"D3"|"Titan"|"Other";
  skills: Skill [];
}

let gdClasses : GdClass [] = [
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
