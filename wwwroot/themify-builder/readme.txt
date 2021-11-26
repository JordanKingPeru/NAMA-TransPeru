=== Themify Builder ===
Contributors: themifyme
Plugin Name: Themify Builder
Tags: builder, drag-and-drop, page-builder, drag-and-drop-builder, layout, layout-builder, page, content, editor, content-builder, column, grid, responsive, visual, visual-builder, wysiwyg, template, template-builder, gutenberg
Requires at least: 4.5.1
Tested up to: 5.8.1
Stable tag: 5.3.3

Build responsive layouts that work for desktop, tablets, and mobile using intuitive &quot;what you see is what you get&quot; drag &amp; drop framework with live edits and previews.

== Description ==

The Themify Builder is the most powerful and easy to use page designer and builder for WordPress. Design any layout that you can imagine with  its drag and drop interface, and with live preview, you can see everything come together right in front of your eyes. Simply select, drag and drop, and you've built beautiful pages - without any coding!

The Builder is modular in design and is optimized for better performance resources. It's also SEO friendly, translatable, and supports multi-site networks. In addition, it comes with  its own cache system that reduces the server resources and process processes pages faster. Works on any post type, support HTML input, and play well with all major plugins such as WooCommerce, SEO Yoast, Disqus, MailChimp, Jetpack, WPML, and Contact Form 7.

= Themify Builder - Overview =
[youtube https://www.youtube.com/watch?v=4noQ8bKxQ0k]

= Builder Features: =

*   Responsive across all resolutions.
*   Frontend live preview editing.
*   Compact backend Builder editing.
*   Includes all modules (Text, Video, Accordion, Gallery, Post, Widgetized, Widget, Menu, Button, Slider, Map, Icon, Feature, etc.)
*   Custom styling - Google fonts, background color, padding, margin, and border.
*   Undo/Redo Builder modifications as you edit.
*   Copy/Paste modules, rows, and columns.
*   Import/Export specific modules, rows, and columns from one computer to another.
*   Easily duplicate any module or row.
*   Row and column layout pre-set grids. Rows and columns can be nested in sub rows or columns.
*   Draggable column widths.
*   60+ predesigned Builder layouts.
*   60+ animation effects.
*   Responsive Styling.
*   Background - slider, video, parallax scrolling, and gradient. 
*   Revisions - allows you to save your Builder layout with unlimited versions.
*   Visibility control where you can set whether a module or row is visible on a specific device.
*   Layout parts - re-usable parts that can be included in the Builder.
*   Custom CSS


== Installation ==

1. Upload the whole plugin directory to the `/wp-content/plugins/` directory
2. Activate the plugin through the 'Plugins' menu in WordPress
3. Enjoy!

== Changelog ==

= 5.3.3 (2021.10.15) =
* New: Builder: add mobile style layout
* New: Builder: Add hook content on Post module
* Fix: Builder: If classic editor is enabled switch to frontend themify builder is not working

= 5.3.2 (2021.09.29) =
* Fix: Builder: Fix input escape issue
* Fix: Builder: JS error when you remove the only remaining item in a repeater field

= 5.3.1 (2021.09.27) =
* Fix: Builder: Images are not visible on Builder mode
* Fix: Builder: Icon alignment is not working on live page
* Fix: Builder: Cannot exclude categories by categories name in post module
* Fix: Builder: Wrong css selector for Icon ?none? style
* Fix: Builder: Right Click Interface Menu option does not work
* Fix: Builder: Backend builder module panel is not scrollable
* Fix: Builder: Content added below image module does not render
* Fix: Builder: The transform option does not work for the text module
* Fix: Builder: Nextgen gallery plugin is not compatible in new version
* Fix: Builder: Gallery Module Slider Caption is not working
* Fix: Builder: In Slider Module the Image Display's Size settings are not working
* Fix: Builder: In Slider Module with auto height selected the Slides to appear at different sizes
* Fix: Builder: Drag and drop function is not working on Firefox
* Fix: Builder: Inline editing is not working for subheading in fancy heading module
* Fix: Builder: Link Block module links do not work
* Fix: Builder: In Safari Browser inline editor does not work
* Fix: Builder: Row overview visibility hint is not updating
* Fix: Builder: If label is missing the icon image will not show in icon module
* New: Builder: Add background styling option for date in post module
* New: Builder: Add position option for image modules
* Fix: Builder: Responsive styling does not work for margin-value added inside Rows
* Fix: Builder: Anchor scrolling not working properly
* Fix: Builder: On imported layout, the Builder unstick fails due to ID changes
* Fix: Builder: Post Grid 2 Thumb Layout no margin if Post Filter is enabled.
* Fix: Builder: In frontend builder on the mobile mode dragging the modules places them on the left of the screen
* Fix: Builder: Frontend builder do not work correctly
* Fix: Builder: In Image Module the Image Overlay should inherit the border-radius of the Image
* Fix: Builder: Icon module: vertical right alignment doesn't work
* Fix: Builder: ??Scroll effects are applied even after disabling them
* Fix: Builder: Service menu title is not following the module styling
* Fix: Builder: Duplicating a page shows a critical error 
* Fix: Builder: Crawlable link issue on using javascript:void(0)
* Fix: Builder: Layout parts render incorrectly if added to a post type that is disabled in Builder
* Fix: Builder: Disable image resizer on Gallery/Slider/Post for better performance

= 5.3.0 (2021.07.28) =
* New: Builder: Add inline editor (new feature)
* New: Builder: Add inline image resizer for specifying image width/height
* New: Builder: Add an option to select html tag for title in various modules
* Fix: Builder: Column alignments are not working properly
* Fix: Builder: Video Module: In the Safari browser the volume button does not work in self-hosted videos
* Fix: Builder: Offset scrollTo triggers auto scroll
* Fix: Builder: Image Module: Open incorrect image in ligthbox if URL is relative path
* Fix: Builder: If you insert Layout Part as shortcode, live edit is broken
* Change: Builder: Replace all icon wrapper from <i> to <em> (for WCAG accessibility validation)

= 5.1.3 (2021.06.04) =
* New: Builder: Add image option for WebP image
* Fix: Builder: Text-Module: Gradient in Global Style does not apply
* Fix: Builder: Tablet portrait visibility not working
* Fix: Builder: undefined is added in positioning module styling
* Fix: Builder: If you insert Layout Part as shortcode, live edit is broken
* Fix: Builder: Rankmath compat script causing RM score to not show
* Change: Builder: Tab: Update minimal tab layout styling

= 5.1.2 (2021.06.04) =
* Fix: Builder: Module panel gets hidden if you drag it to wp-admin sidebar
* Fix: Builder: Layout Part live save missing styling
* New: Builder: Login Module: add reCAPTCHA support
* New: Builder: Add dark mode interface option
* Fix: Builder: The embedded video added in first section gets paused as soon as you slide to other section on the page
* Fix: Builder: Option to disable lightbox in Gallery module
* Fix: Builder: Responsive preview mode tablet portrait is not following the configured breakpoints
* Fix: Builder: Subrow overlay is not working

= 5.1.1 (2021.05.11) =
* New: Builder: CSS transform styling
* New: Builder: Add option to disable Builder on post types
* New: Builder: Add form alignment option for login module
* Fix: Builder: Responsive preview mode tablet portrait not following the configured breakpoints
* Fix: Builder: Larger icons distort circles in Icon Module

= 5.1.0 (2021.04.16) =
* New: Builder: Add no background image option for responsive
* Fix: Builder: Slider Module Video adding too much empty space below the Module
* Fix: Builder: Toolbar Builder UI Preview dropdown does not look correct
* Fix: Builder: Mailchimp Optin Form doesn't send double optin confirmation
* Fix: Builder: Builder plugin doesn't work with 2021 theme on product single
* Fix: Builder: Post module not showing excerpts if content is created with Builder
* Fix: Builder: Videos added in slider and slider pro modules are not autoplaying
* Fix: Builder: Hook content not showing in the single product page
* Fix: Builder: Gallery module displays wrong image title in lightbox
* Fix: Builder: Mobile tab option is not working
* Fix: Builder: Pagination styles are missing for the numbers
* Fix: Builder: Cron job doesn't delete concate files correctly
* Fix: Builder: Video Module's height is not responsive to Width changes
* Fix: Builder: Happy form plugin dropdowns are not working 
* Fix: Builder: Speed up Overlay Content and Menu slide in animation
* Fix: Builder: Remove outdated builder module option

= 5.0.9 (2021.03.09) =
* New: Builder: Use breakpoint settings for Builder responsive preview
* New: Builder: Add gallery image gutter styling option
* Fix: Builder: Custom CSS panel goes away after dragging
* Fix: Builder: Facebook jetpack widget is not working
* Fix: Builder: The + button to open the toolbar is missing if the row is not empty
* Fix: Builder: Current page/menu item styling is applied to all submenus nested below it
* Fix: Builder: Video poster image does not fit well

= 5.0.8 (2021.02.22) =
* New: Builder: Add Link Block module
* Fix: Builder: Margins are not working properly in portfolio module
* Fix: Builder: Row/column link styling override Button preset color 
* Fix: Builder: On Menu module, dropdown menu links not displaying on iPad
* Fix: Builder: Module with entrance animation hidden if view with scrollTo
* Fix: Builder: sticky element shifts positions when browser height changes
* Fix: Builder: Sticky modules don't remain sticky when you go off page and back
* Fix: Builder: Right Margins are not working on builder mode
* Fix: Builder: Optin form email field label show twice on the live page
* Fix: Builder: Optin form has console error after submit
* Fix: Builder: Saved Rows can not be added to Builder 
* Fix: Builder: Search conflict with themify event post plugin
* Fix: Builder: Row background slider continuously load images over the network 
* Fix: Builder: Parallax background shows gap on mobile 
* Fix: Builder: Conflict with Formidable form plugin
* Fix: Builder: Return the image/video icon back to zoom icon
* Fix: Builder: Gallery slider mode: animate caption after slide transition is done
* Fix: Builder: With the cube effect, the slider causing text to overlap 
* Fix: Builder: Add hide label text on Icon module (for web accessibility reason)
* Fix: Builder: Builder scrollTo offset doesn't work if header select none

= 5.0.7 (2021.01.16) =
* Change: Builder: Re-coded drag & drop UI with HTML5 (better & smooth performance)
* New: Builder: Add autocomplete when taxonomy/category select has too many items
* Fix: Builder video bg slider plugin has conflict with FW sliders
* Fix: Builder: Lightbox scrolling issue on smaller screens
* Fix: Builder: Speed up Overlay Content slide in animation
* Fix: Builder: Categories selector in all Modules can't load more than 100 Categories
* Fix: Builder: Lightbox scrolling issue on smaller screens
* Fix: Builder: When an animation is selected, preview should show the animation
* Fix: Builder: Row video background insert is not working
* Fix: Builder: In Slider Module the Image Links have alt attribute
* Fix: Builder: Events made easy plugin conflict with builder
* Fix: Builder: Entrance animation doesn't show if it is scrolled with scrollTo anchor
* Fix: Builder: In image module if you have selected full-overlay layout the text added in image caption load in wrong place on page reload
* Fix: Builder: The modal lightbox "X" button is white on white with button pro
* Fix: Builder: Re-map all old Slider fade effects to fade
* Fix: Builder: Toolset compatibility: Gutenberg block style CSS file not loading
* Fix: Builder: Layout Parts and Pro's templates lose styling when editing Builder on frontend
* Fix: Builder: The Play button is not visible on Overlay Image in Safari browser
* Fix: Builder: In slider module add new slide button is showing 3 times

= 5.0.6 (2020.12.15) =
* Changed: Builder: Re-map all old Slider fade effects to fade
* Fix: Slider Module: Auto-scroll off option doesn't work if you have a slider with autoplay above 
* Fix: Builder: Testimonials Module Image Bubble styling not working on live site
* Fix: make the responsive inputs editable in Themify Builder Plugin settings

= 5.0.5 (2020.12.04) =
* New: Builder: Add title attribute to Button module
* New: Builder: Add width and display options in all modules and addons
* New: Builder: Add required attribute to the login form field\
* Fix: Builder: Module visibility indicator icon doesn't show on re-edit
* Fix: Builder: In section scrolling align-top is not working for the grids/column settings
* Fix: Builder: Row background-position does not work when best fit is selected
* Fix: Builder: Accordion containing Themify shortcode overlaps with the below accordion title
* Fix: Builder: Cannot have different content layout set for post modules used in the page
* Fix: Builder: Gallery issues with "Slider" mode
* Fix: Builder: Preview mode doesn't work with visibility options
* Fix: Builder: Vimeo video does not work as background row video
* Fix: Builder: Backend Text module missing preview text
* Fix: Builder: Img title attribute doesn't output if alt and title both entered in media library image
* Fix: Builder: content does not display in correct location if access control shortcodes are used
* Fix: Builder: content shows in wrong location when Gutenberg page break is used
* Fix: Builder: On image module, if full-overlay layout is selected, the image caption text loads in wrong place

= 5.0.4 (2020.11.25) =
* New: Builder: Post filter styling option missing in post and portfolio module
* Change: Builder: Use page title as the email subject in email share icon
* Change: Builder: Change visibility handling based on responsive breakpoint settings 
* Fix: Builder: On iOS row background with fixed background-attachment appears very large
* Fix: Builder: Enhance parallax background on all devices
* Fix: Builder: Hide row anchor on URL doesn’t work
* Fix: Builder: Sticky issue on some situations
* Fix: Builder: Lazy loading function is not working properly with anchor scrolling
* Fix: Builder: ScrollTo anchor doesn't work on old iOS 12.4.8
* Fix: Builder: Videos added in slider are not working
* Fix: Builder: Post module navigation not showing active after 4 pages
* Fix: Builder: Gallery module > slider mode, image title/caption not showing
* Fix: Builder: Update Optin Form > Newsletter provider API error
* Fix: Builder Framework : Cancel X Button does not work properly
* Fix: Builder: If you have an overlay image enabled on video module clicking the play button mute the audio
* Fix: Builder: Sliders image size not correct and doesn’t following the selected visible slides if the effect is set to fade or cross fade
* Fix: Builder: Themify Social Links widget does not work via Builder Widget module
* Fix: Builder: Testimonial post module fullwidth layout is not working properly
* Fix: Builder: On Safari, Builder row module and grid icons are broken
* Fix: Builder: In section scrolling align-top is not working for the grids/column settings 
* Fix: Builder: Post module layout gets affected if you change featured image position in archive layout settings
* Fix: Builder: Can't disable related videos in Video module by add &rel=0

= 5.0.3 (2020.11.06) =
* Fix: Builder: Button link text decoration not working in button module
* Fix: Builder: Page Break pagination doesn't work on single post
* Fix: Builder: Autoplay not working for self-hosted videos
* Fix: Builder: Page jumps to top if row has anchor on iPhone Chrome
* Fix: Builder: ScrollTo doesn't work properly if you enter full URL path anchor

= 5.0.2 (2020.11.04) =
* Fix: Builder: Wrong image size output in width/height img attribute
* Fix: Builder: Gallery Slider Auto Scroll time above 10s not working
* Fix: Builder: Feature module in hidden row causes scroll flicker on iPhone
* Fix: Builder: Lazy load doesn't work on old browsers 
* Fix: Builder: Accordion Open by default when set to closed
* Fix: Builder: If you set visible slides=4 for tablet, mobile visible slide option won't work
* Fix: Builder: On Text module, the Insert link option does not work correctly on frontend
* Fix: Builder: Creating Global Style from Dashboard does not work
* Fix: Builder: Global Style loses selection in the backend Builder
* Fix: Builder: Margin top added in rows and columns not work in preview mode
* Fix: Builder: More link doesn't work in Post module
* Fix: Builder: Gallery images linked to attachment pages cause blank lightbox
* Fix: Builder: Posts not showing after Search and Filter Pro plugin activated 

= 5.0.1 (2020.10.27) =
* Fix error in old versions of PHP

= 5.0.0 (2020.10.23) =
* WARNING: This is a major update. Please test it on a staging site before updating on live site.
* WARNING: All Builder addons must be updated to 2.0+ to use with Builder 5.0+
* New: Lazy load images, videos, sliders, maps, etc.
* New: Modularize CSS (ie. split the css and only load them as needed)
* New: Builder: Added Overlay Content module
* Change: Builder: Replace slider JS to swiper.js
* Change: Builder: Replace icon font to individual SVG icon
* Fix: YouTube/Vimeo background video not covering the full row
* Fix: Builder: content does not display in correct location if access control shortcodes are used
** If you need to roll back to the old version due to update issues, you may download the old version here: https://themify.me/files/themify-builder/themify-builder-4.7.4.zip
