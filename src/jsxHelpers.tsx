(function(app,exposeYourself:boolean){
app.createInputClipperButton = targetId =>
  app.Clipboard && app.Clipboard.isSupported() && (<button className="btn" data-clipboard-target={"#" + targetId}>Copy to Clipboard</button>);
app.createClipperButton = text =>
  app.Clipboard && app.Clipboard.isSupported() && (<button className="btn" data-clipboard-text={text}>Copy to Clipboard</button>);

app.Checkbox = props =>
  (<input type="checkbox"
      onChange={props.onChange ? (e => props.onChange(e.target.value)) : undefined}
      disabled={props.disabled}
      // this should help it not say controlled to uncontrolled component
      checked={props.checked || false}
      readOnly={props.readonly} />);
app.Checkbox.displayName = "Checkbox";

interface UnorderedListProps<T> {
  sorter (a:T,b:T):number
  items: T[]
  displayMap? (item:T) : any
  keyMaker (item:T) : any
}

app.UnorderedList = function UnorderedList<T>(props:UnorderedListProps<T>) {
  var items = (props.sorter ? props.items.slice(0).sort(props.sorter) : props.items);
  // if(props.displayMap != null)
  //   items = items.map(displayMap)
  return (<ul>{items.map(item => (<li key={props.keyMaker(item)}>{props.displayMap ? props.displayMap(item):item}</li>))}
  </ul>);
};


var TextAreaInput2 = props =>
(<textarea
    name={props.name}
    className={app.addClasses(['form-control'],props.className)}
    type={props.type}
    value={props.value}
    defaultValue={props.defaultValue}
    placeholder={props.placeHolder}
    onChange={ e =>
        {
        if(props.onControlledChange){
            props.onControlledChange(e);
        }
        return app.debounceChange(props.onChange,e)
      }
    }
    onBlur={props.onBlur}
    {...props.spread} />
);
(TextAreaInput2 as any).displayName = "TextAreaInput2";

//bad naming, TextInput2 looks from the outside like it should be the better option over TextInputUnc, but really, TextInputUnc is what we should always want as far as I can tell
var TextInput2 = props =>
(<input
        id={props.id}
        name={props.name}
        className={app.addClasses(['form-control'],props.className)}
        type={props.type}
        value={props.value}
        defaultValue={props.defaultValue}
        placeholder={props.placeHolder}
        readOnly={props.readonly}
        min={props.min}
        max={props.max}
        step={props.step}
        onChange={ e =>
            {
            if(props.onControlledChange){
                props.onControlledChange(e);
            }
            return app.debounceChange(props.onChange,e)
          }
        }
        onBlur={props.onBlur}
        {...props.spread} />);

(TextInput2 as any).displayName = "TextInput2";

interface TextInputUncProp{
  value?:string
  placeHolder?:string
  debug?:boolean
  name:string
  id:string
  defaultValue:string
  type:string
  min?:number
  max?:number
  step?:number
  readonly?:boolean
  className?:string[]|string
  onChange (e:any) : void
  spread? : any
}

interface TextInputUncState{
  value?:string
}

// looks uncontrolled, but is not under the hood. better user experience
class TextInputUnc extends React.Component<TextInputUncProp,TextInputUncState> {
  constructor(props){
    super(props)
    this.getInitialState = this.getInitialState.bind(this);
    this.state = this.getInitialState(props);
  }
  getInitialState(props){
    return {value:props.value};
  }
  componentWillReceiveProps(nextProps){
    if(this.props.debug)
      console.log('TextInputUnc componentWillReceiveProps', this.props, nextProps);
    // this used to check more stuff before it would try to change state
    if(this.props.value !== nextProps.value && this.state.value !== nextProps.value){
      this.setState({value:nextProps.value});
    }
  }
  render(){
    var props = this.props;
    var state = this.state;
    if(!(props.placeHolder != null) && (props as any).placeholder !=null)
      console.warn('TextInputUnc expects prop placeHolder not placeholder');
    return (<TextInput2
          name={props.name}
          id={props.id}
          defaultValue={props.defaultValue}
          value={state.value != null ? state.value : ''}
          type={props.type}
          min={props.min}
          max={props.max}
          step={props.step}
          readonly={props.readonly}
          placeHolder={props.placeHolder}
          className={props.className}
          onControlledChange={e => this.setState({value: e.target.value})}
          onChange={e => props.onChange(e)}
          onBlur={e => e.target.value === '' ? {} : e.target.value = (+e.target.value)}
          spread={props.spread}
      />
      );
  }
};
(TextInputUnc as any).displayName = "TextInputUnc";
app.TextInputUnc = TextInputUnc;

// interface TextAreaInputUncProp{
//   value?:string
//   id?:string
//   name?:string
//   className?: string[] | string
//   defaultValue?:string
//   placeHolder?:string
//   type:string


// }

class TextAreaInputUnc extends React.Component<TextInputUncProp,TextInputUncState> {
  constructor(props){
    super(props);
    this.getInitialState = this.getInitialState.bind(this);
    this.state = this.getInitialState(props);
  }
  getInitialState(props){
    return {value:props.value};
  }
  componentWillReceiveProps(nextProps){
    if(this.props.value !== nextProps.value && this.props.id !== nextProps.id){
      this.setState({value:nextProps.value});
    }
  }
  render(){
    var props = this.props;
    var state = this.state;
    return (<TextAreaInput2
          name={props.name}
          className={props.className}
          defaultValue={props.defaultValue}
          value={state.value? state.value : ''}
          placeHolder={props.placeHolder}
          type={props.type}
          min={props.min}
          onControlledChange={e => this.setState({value: e.target.value})}
          onChange={e => props.onChange(e)}
          onBlur={e => e.target.value === '' ? {} : e.target.value = (+e.target.value)}
          spread={props.spread}
      />
      );
  }
};
(TextAreaInputUnc as any).displayName = "TextAreaInputUnc";
app.TextAreaInputUnc = TextAreaInputUnc;

interface TabProps{
  selected?:number
  onTabChange? (nextIndex:number,paneItem?:any):void
}
interface TabState{
  selected:number
}
// from https://toddmotto.com/creating-a-tabs-component-with-react/
class Tabs extends React.Component<TabProps,TabState> {
  constructor(props){
    super(props);
    this._renderTitles = this._renderTitles.bind(this);
    this.getInitialState = this.getInitialState.bind(this);
    this.state = this.getInitialState(props);
  }
  displayName: 'Tabs'
  getInitialState(props){
    return {selected:props.selected};
  }
  componentWillReceiveProps(nextProps){
    if(nextProps.selected != this.props.selected){
      this.setState({selected:nextProps.selected});
    }
  }
  handleClick(index,event){
    event.preventDefault();
    if(this.props.onTabChange)
      this.props.onTabChange(index, this.props.children && (this.props.children as any[]).length > index && index >= 0 ? this.props.children[index] : undefined);
    this.setState({
      selected: index
    });
  }
  _renderTitles(){
    function labels(child,index){
      var activeClass = this.state.selected === index ? 'activeTab':'';
      return(
        <li key={index}>
          <a href="#"
            onClick={this.handleClick.bind(this,index)}
            className={activeClass}
          >
            {child.props.label}
          </a>
        </li>
      );
    }
    return (<ul className="tabs__labels">
        {(this.props.children as any[]).map(labels.bind(this))}
        </ul>
      );

  }
  _renderContent(){
    return (
      <div className="tabs__content">
        {(this.props.children as any[])[this.state.selected]}
      </div>
    );
  }
  render(){
    return (
    <div className="tabs">
      {this._renderTitles()}
      {this._renderContent()}
    </div>);
  }
};

(Tabs as any).defaultProps = {
  selected:0
};
app.Tabs = Tabs;

interface PaneProps{
  label:string
}

interface PaneState{ }

class Pane extends React.Component<PaneProps,PaneState> {
  displayName:'Pane'
  render(){
    return(<div>{this.props.children}</div>);
  }
};
app.Pane = Pane;

})(findJsParent(), false);